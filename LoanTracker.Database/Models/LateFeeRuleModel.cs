﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanTracker.Database.Models;

public class LateFeeRuleModel
{
    public string Id { get; set; }
    public int MinDaysOverdue { get; set; }
    public int MaxDaysOverdue { get; set; }
    public decimal LateFeeAmount { get; set; }
}

public class UpdateLateFeeRequest
{
    public string LoanId { get; set; }
    public decimal NewLateFee { get; set; }
}