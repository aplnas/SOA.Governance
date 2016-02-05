﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository.Contracts
{
     public class PagedResult<TEntity>
     {
          IEnumerable<TEntity> _items;
          int _totalCount;

          public PagedResult(IEnumerable<TEntity> items, int totalCount)
          {
               _items = items;
               _totalCount = totalCount;
          }

          public IEnumerable<TEntity> Items { get { return _items; } }
          public int TotalCount { get { return _totalCount; } }
     }
}
