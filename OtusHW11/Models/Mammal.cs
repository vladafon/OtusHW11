using OtusHW11.Models.Abstract;
using System.Text;

namespace OtusHW11.Models
{
    /// <summary>
    ///     Млекопитающее.
    /// </summary>
    public class Mammal : Animal, IMyClonable<Mammal>, ICloneable
    {
        public Mammal(string name,
            List<Organ> organs,
            int limbsCount,
            int eyesCount,
            bool hasTail,
            int averageChildrenCount) : base(name, organs, limbsCount, eyesCount, hasTail)
        {
            AverageChildrenCount = averageChildrenCount;
        }

        /// <summary>
        ///     Среднее количество потомков.
        /// </summary>
        public int AverageChildrenCount { get; set; }

        public object Clone() 
            => MyClone();

        public Mammal MyClone()
            => new Mammal(Name, Organs, LimbsCount, EyesCount, HasTail, AverageChildrenCount);

        public override string? ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.Append($"Среднее количество потомков: {AverageChildrenCount}\n");

            return sb.ToString();
        }
    }
}
