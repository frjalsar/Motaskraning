﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotaskraningWeb.Models
{
    public class Domari
    {
        public string nafn { get; set; }
    }

    public class Grein
    {
        public string nafnGreinar { get; set; }
        public string gerdGreinar { get; set; }
    }

    public class MotaskraningModel
    {
        public List<Domari> Domarar { get; set; }
        public List<Grein> Greinar { get; set; }
        public Skraning skraning { get; set; }
    }

    public class Skraning
    {
        public string motshaldari { get; set; }
        public string stadsetning { get; set; }
        public string domari { get; set; }
        public List<Grein> greinar { get; set; }
    }

    // Jira klasar -------------------------------------
    public class fieldHolder
    {
        public fields fields { get; set; }
    }

    public class fields
    {
        public Project project { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public Issuetype issuetype { get; set; }
        public Assignee assignee { get; set; }
    }

    public class Assignee
    {
        public string name { get; set; }
    }

    public class Issuetype
    {
        public string name { get; set; }
    }

    public class Project
    {
        public string key { get; set; }
    }

    // Klasar fyrir að ná í lista af félögum
    public class club
    {
        public int id { get; set; }
        public string? fullName { get; set; }
        public string? shortName { get; set; }
        public string? abbreviation { get; set; }
        public string? thorId { get; set; }
        public int? regionId { get; set; }
        public Region? region { get; set; }
    }

    public class Region
    {
        public int? id { get; set; }
        public string? fullName { get; set; }
        public string? abbreviation { get; set; }
    }

    // Klasar fyrir það að ná í lista af greinum
    public class events
    {
        public string? Id { get; set; }
        public int? Gender { get; set; }
        public string? AgeCategory { get; set; }
        public int? Outside { get; set; }
        public string? Name { get; set; }
        public string? EventCode { get; set; }
        public string? CompoundKey { get; set; }
        public string? EventCodeForRegistration { get; set; }
    }

}