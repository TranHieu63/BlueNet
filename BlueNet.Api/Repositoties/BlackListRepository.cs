using BlueNet.Api.Data;
using BlueNet.Api.Entities;
using BlueNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueNet.Api.Repositoties
{
    public class BlackListRepository : IBlackListRepository
    {
        private readonly BlueNetDbContext _context;
        
        public BlackListRepository(BlueNetDbContext context)
        {
            _context = context;
        }

        //GetAll
        public async Task<IEnumerable<Entities.BlackList>> GetBlackList(BlackListSearch blackListSearch)
        {
            var query = _context.BlackLists
                .Include(x => x.User).AsQueryable();

            if (!string.IsNullOrEmpty(blackListSearch.Url))
                query = query.Where(x => x.Url.Contains(blackListSearch.Url));

            //if (blackListSearch.UserId.HasValue)
            //    query = query.Where(x => x.UserId == blackListSearch.UserId.Value);

            return await query.OrderByDescending(x => x.CreatedDate).ToListAsync();
        }

        public async Task<IEnumerable<Entities.BlackList>> GetBlackListByUserId(Guid userId, BlackListSearch blackListSearch)
        {
            var query = _context.BlackLists
                .Where(x => x.UserId == userId).AsQueryable();

            if (!string.IsNullOrEmpty(blackListSearch.Url))
                query = query.Where(x => x.Url.Contains(blackListSearch.Url));

            if (blackListSearch.UserId.HasValue)
                query = query.Where(x => x.UserId == blackListSearch.UserId.Value);

            return await query.OrderByDescending(x => x.CreatedDate).ToListAsync();
        }

        //GetById
        public async Task<BlackList> GetById(Guid id)
        {
            return await _context.BlackLists.FindAsync(id);
        }

        //Create
        public async Task<BlackList> Create(BlackList blackList)
        {
            await _context.BlackLists.AddAsync(blackList);
            await _context.SaveChangesAsync();
            return blackList;
        }
      
        //Update
        public async Task<BlackList> Update(BlackList blackList)
        {
            _context.BlackLists.Update(blackList);
            await _context.SaveChangesAsync();
            return blackList;
        }

        //Delete
        public async Task<BlackList> Delete(BlackList blackList)
        {
            _context.BlackLists.Remove(blackList);
            await _context.SaveChangesAsync();
            return blackList;
        }

        public async Task<bool> CheckUrl(CheckUrlParameter checkUrl)
        {

            bool result = false;

            //int userId = checkUrlParameter.UserId;
            string url = checkUrl.Url;
            //Guid UserId = checkUrl.UserId;

            //lấy ra tất cả blacklist
            List<BlackList> blackListAll = await _context.BlackLists.ToListAsync();

            //Check url blackList có trùng url và userId ng tạo k
            //nếu trùng => return true, còn k trùng => return false

            for (int i = 0; i < blackListAll.Count; i++)
            {
                BlackList blackList = blackListAll[i];
                if (blackList.Url == url)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
