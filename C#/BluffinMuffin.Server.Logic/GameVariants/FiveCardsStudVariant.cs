﻿using System;
using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes.Enums;
using BluffinMuffin.Server.DataTypes;
using BluffinMuffin.Server.DataTypes.Attributes;
using BluffinMuffin.Server.DataTypes.EventHandling;
using BluffinMuffin.Server.Logic.GameModules;

namespace BluffinMuffin.Server.Logic.GameVariants
{
    [GameVariant(GameSubTypeEnum.FiveCardsStud)]
    public class FiveCardsStudVariant : AbstractStudGameVariant
    {
        public override int NbCardsInHand => 5;

        public override IEnumerable<IGameModule> GetModules(PokerGameObserver o, PokerTable t)
        {
            yield return new DealCardsToPlayersModule(o, t, 1, 1);
            yield return new StudFirstBettingRoundModule(o, t);
            yield return new CumulPotsModule(o, t);

            yield return new DealCardsToPlayersModule(o, t, 0, 1);
            yield return new BettingRoundModule(o, t);
            yield return new CumulPotsModule(o, t);

            yield return new DealCardsToPlayersModule(o, t, 0, 1);
            yield return new BettingRoundModule(o, t);
            yield return new CumulPotsModule(o, t);

            yield return new DealCardsToPlayersModule(o, t, 0, 1);
            yield return new BettingRoundModule(o, t);
            yield return new CumulPotsModule(o, t);
        }
    }
}
