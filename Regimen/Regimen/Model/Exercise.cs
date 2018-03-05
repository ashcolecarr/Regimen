using System;
using System.Collections.Generic;
using System.Text;

namespace Regimen.Model
{
    /// <summary>
    /// An exercise
    /// </summary>
    public class Exercise
    {
        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The reps
        /// </summary>
        public string Reps { get; set; }
    }
}
