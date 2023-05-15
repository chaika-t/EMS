namespace EmployeeManagementSystem.Common.Controllers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a DArray of Employee objects with accessors
    /// </summary>
    /// <typeparam name="TKey">Database key type</typeparam>
    /// <typeparam name="TValue">Database value type</typeparam>
    public sealed class BusinessRules<TKey, TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRules{TKey,TValue}"/> class
        /// </summary>
        public BusinessRules()
        {
            this.Database = new SortedDictionary<TKey, TValue>();
        }

        /// <summary>
        /// Gets or sets access to the Employee database, allows retrieval and setting access
        /// </summary>
        public SortedDictionary<TKey, TValue> Database { get; set; }

        /// <summary>
        /// Returns an Employee object stored at provided index
        /// </summary>
        /// <param name="key">Index to retrieve object from</param>
        /// <returns>Employee object located at indexed location</returns>
        /// <exception cref="ArgumentException">Thrown if key is not in <c>Database</c></exception>
        public TValue Retrieve(TKey key)
        {
            if (!this.Database.ContainsKey(key))
            {
                throw new ArgumentException(Properties.Resources.MissingKeyError);
            }
            
            return this.Database[key];
        }
       
    }
}