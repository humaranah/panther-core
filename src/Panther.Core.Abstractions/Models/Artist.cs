﻿using System;
using System.Collections.Generic;

namespace Panther.Core.Models
{
    public class Artist : IIdentificable, IEquatable<Artist>
    {
        #region Primary key
        /// <summary>
        /// Autogenerated artist id
        /// </summary>
        public long Id { get; set; }
        #endregion


        #region Artist properties
        /// <summary>
        /// Artist name
        /// </summary>
        public string Name { get; set; }
        #endregion


        #region Navigation properties
        /// <summary>
        /// Albums
        /// </summary>
        public ICollection<Album> Albums { get; set; }
        #endregion


        #region Implementations
        public bool Equals(Artist other) =>
            Id == default ? Name == other.Name : Id == other.Id;
        #endregion
    }
}
