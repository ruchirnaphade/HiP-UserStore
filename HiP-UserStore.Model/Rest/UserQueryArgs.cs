﻿namespace PaderbornUniversity.SILab.Hip.UserStore.Model.Rest
{
    public class UserQueryArgs : QueryArgs
    {
        /// <summary>
        /// Restricts the response result to users having the specified role.
        /// </summary>
        public string Role { get; set; }
    }
}
