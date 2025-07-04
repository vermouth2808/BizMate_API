﻿using BizMate.Application.Common.Responses;

namespace BizMate.Application.UserCases.InventoryReceipt.Commands.CreateInventoryReceipt
{
    public class CreateInventoryReceiptResponse : BaseResponse
    {
        public Guid Id { get; set; }
        public string InventoryCode { get; set; } = default!;
        public DateTime Date { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 1 = Import (Phiếu nhập), 2 = Export (Phiếu xuất)
        /// </summary>
        public int Type { get; set; }

        // Store info
        public Guid StoreId { get; set; }
        public string StoreName { get; set; } = default!;

        // Creator info
        public Guid CreatedByUserId { get; set; }
        public string CreatedByUserName { get; set; } = default!;

        // Optional info based on Type
        public string? SupplierName { get; set; }      // If Import
        public string? CustomerName { get; set; }      // If Export
        public string? CustomerPhone { get; set; }
        public string? DeliveryAddress { get; set; }

        public string? Description { get; set; }
        public uint RowVersion { get; set; }

        // Receipt Details
        public IEnumerable<InventoryReceiptDetailDto> InventoryDetails { get; set; } = new List<InventoryReceiptDetailDto>();

        public CreateInventoryReceiptResponse(bool success = true, string? message = null) : base(success, message)
        {
        }
    }

    public class InventoryReceiptDetailDto
    {
        public Guid InventoryReceiptId { get; set; }
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; } 
        public string? ProductCode { get; set; }
        public int Unit { get; set; }

        public int Quantity { get; set; }
    }
}
