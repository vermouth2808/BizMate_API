﻿using BizMate.Domain.Entities;
using SqlKata.Execution;

namespace BizMate.Application.Common.Interfaces.Repositories
{
    public interface IInventoryReceiptRepository
    {
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
        Task UpdateAsync(InventoryReceipt receipt);
        Task DeleteAsync(Guid id);
        Task<List<InventoryReceipt>> SearchReceipts(Guid storeId, int? type, string? keyword, QueryFactory queryFactory);
        Task<(List<InventoryReceipt> Receipts, int TotalCount)> SearchReceiptsWithPaging(Guid storeId, int? type, string? keyword, int pageIndex, int pageSize, QueryFactory queryFactory);
        Task AddAsync(InventoryReceipt receipt);
        Task<InventoryReceipt?> GetByIdAsync(Guid id);
    }
}
