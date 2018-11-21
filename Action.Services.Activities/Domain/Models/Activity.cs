﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Action.Services.Activities.Domain.Models
{
    public class Activity
    {
        public Guid Id { get; protected set; }
        public string Category { get;protected set; }
        public string Name { get; protected set;}
        public string Description { get; protected set;}
        public Guid UserId { get; protected set; }
        public DateTime CreatedAt { get; protected set;}

        protected Activity()
        {
            
        }

        public Activity(Guid id, string category, string name, string description, Guid userId, DateTime createdAt)
        {
            Id = id;
            Category = category;
            Name = name.ToLowerInvariant();
            Description = description;
            UserId = userId;
            CreatedAt = createdAt;  
        }


    }
}
