﻿using System.Collections.Generic;

namespace BypassList
{
    /// <summary>
    /// Describes an unconditional rule.
    /// </summary>
    public class UnconditionalRule : IRule
    {
        private readonly int toSeal;
        private readonly int toCrossOut;
        private readonly int nextDepartment;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnconditionalRule"/> class.
        /// </summary>
        public UnconditionalRule(int toSeal, int toCrossOut, int nextDepartment)
        {
            this.toSeal = toSeal;
            this.toCrossOut = toCrossOut;
            this.nextDepartment = nextDepartment;
        }

        /// <summary>
        /// Seales and returns the index of the next department.
        /// </summary>
        public int Next(HashSet<int> seales)
        {
            seales.Add(toSeal);
            seales.Remove(toCrossOut);

            return nextDepartment;
        }
    }
}