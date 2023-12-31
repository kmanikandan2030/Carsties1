﻿namespace AuctionService.Entities;

public class Auction
{
  public Guid Id { get; set; }
  public int ReservePrice { get; set; }
  public int? SoldAmount { get; set; }
  public int? CurrentHighBid { get; set; }
  public string Seller { get; set; }
  public string Winner { get; set; }
  public Status Status { get; set; }
  public Item Item { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow; /* UTC postgress required */
  public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; /* UTC postgress required */
  public DateTime AuctionEnd { get; set; }
}
