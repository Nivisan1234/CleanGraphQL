﻿namespace Mediator.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }

        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;

    }
}
