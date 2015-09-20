﻿using System.Collections.Generic;
using BluffinMuffin.HandEvaluator;
using BluffinMuffin.Protocol.DataTypes;

namespace BluffinMuffin.Server.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class MoneyPot
    {
        #region Fields
        private readonly List<WinningPlayer> m_AttachedPlayers = new List<WinningPlayer>();
        #endregion Fields

        #region Properties

        /// <summary>
        /// Sequence given to the actual MenyPot
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Amount of money in the Pot
        /// </summary>
        public int Amount { get; private set; }

        /// <summary>
        /// Number of player playing for this Pot
        /// </summary>
        public WinningPlayer[] AttachedPlayers => m_AttachedPlayers.ToArray();

        #endregion Properties

        #region Ctors & Init

        public MoneyPot(int id, int amount = 0)
        {
            Id = id;
            Amount = amount;
        }
        #endregion Ctors & Init

        #region Public Methods
        
        /// <summary>
        /// Attach a player to the MoneyPot
        /// </summary>
        public void AttachPlayer(PlayerInfo p, HandEvaluationResult h = null)
        {
            m_AttachedPlayers.Add(new WinningPlayer() { Player = p, Hand = h });
        }

        /// <summary>
        /// Detach all players from the MoneyPot
        /// </summary>
        public void DetachAllPlayers()
        {
            m_AttachedPlayers.Clear();
        }

        /// <summary>
        /// Add money to the pot !
        /// </summary>
        public void AddAmount(int added)
        {
            Amount += added;
        }
        #endregion Public Methods
    }
}
