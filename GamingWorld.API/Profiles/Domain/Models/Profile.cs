﻿using System.Collections.Generic;
using GamingWorld.API.Security.Domain.Models;

namespace GamingWorld.API.Profiles.Domain.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public EGamingLevel GamingLevel { get; set; }
        public bool IsStreamer { get; set; }
        
        public User User { get; set; }
        public IEnumerable<GameExperience> GameExperiences { get; set; }
        
        public IEnumerable<StreamingCategory> StreamingCategories { get; set; }
        
        public IEnumerable<StreamerSponsor> StreamerSponsors { get; set; }
        
        public IEnumerable<TournamentExperience> TournamentExperiences { get; set; }
        public IEnumerable<FavoriteGame> FavoriteGames { get; set; }
    }
}