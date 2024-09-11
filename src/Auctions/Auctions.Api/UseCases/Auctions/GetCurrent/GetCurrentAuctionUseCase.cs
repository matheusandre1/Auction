﻿using Auctions.Api.Entities;

namespace Auctions.Api.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction Execute()
        {
            return new Auction()
            {
                Id = 1,
                Name = "Test",
                Starts = DateTime.Now,
                Ends = DateTime.Now,
            };
        }
    }
}
