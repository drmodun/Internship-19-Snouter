﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.BuyersProducts
{
    public class GetBuyersProudctsRequest
    {
        public Guid ProductId;
        public Guid UserId;
    }
}
