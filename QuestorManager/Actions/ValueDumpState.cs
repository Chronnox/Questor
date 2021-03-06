﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestorManager.Actions
{
    public enum ValueDumpState
    {
        Idle,
        Begin,
        Done,
        GetItems,
        UpdatePrices,
        NextItem,
        StartQuickSell,
        WaitForSellWindow,
        InspectOrder,
        InspectRefinery,
        WaitingToFinishQuickSell,
        CheckMineralPrices,
        GetMineralPrice,
        RefineItems,
        WaitingToBack,
        SaveMineralPrices
    }
}
