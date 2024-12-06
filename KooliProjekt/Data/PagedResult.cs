﻿namespace KooliProjekt.Data
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; } = new List<T>();
    }
}
