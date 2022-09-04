﻿using CodTrackerCore.Models;
using MongoDB.Driver;

namespace CodTrackerInfrastructure.Interfaces;

public interface IMongoDbContext
{
    IMongoCollection<Match> Matches { get; set; }
    IMongoCollection<User> Users { get; set; }
}