using System;
using System.Collections.Generic;

public class User
{
    public int UserID { get; set; }         // Primary Key
    public string UserName { get; set; }    // User's name
    public string Email { get; set; }       // User's email address
    public string Password { get; set; }    // User's password (consider hashing this)
    public List<Prediction> Predictions { get; set; } // Navigation Property: User can have many Predictions
    public string Role { get; internal set; }
}
