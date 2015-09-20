﻿using System;
using BluffinMuffin.HandEvaluator;
using BluffinMuffin.HandEvaluator.Selectors;

namespace BluffinMuffin.Server.Logic.GameVariants
{
    public abstract class AbstractStudGameVariant : AbstractGameVariant
    {
        public bool NeedsBringIn { get; set; } = false;

        public override EvaluationParams EvaluationParms => new EvaluationParams
        {
            Selector = new OnlyHoleCardsSelector()
        };
    }
}
