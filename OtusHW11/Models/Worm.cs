using OtusHW11.Models.Abstract;
using System.Text;

namespace OtusHW11.Models
{
    /// <summary>
    ///     Червь.
    /// </summary>
    public class Worm : Animal, IMyClonable<Worm>, ICloneable
    {
        public Worm(string name,
            List<Organ> organs, 
            int limbsCount, 
            int eyesCount, 
            bool hasTail, 
            bool hasRegeneration) : base(name, organs, limbsCount, eyesCount, hasTail)
        {
            HasRegeneration = hasRegeneration;
        }

        /// <summary>
        ///     Признак, показывающий, обладает ли червь способностью к регенерации.
        /// </summary>
        public bool HasRegeneration { get; }

        public object Clone()
            => MyClone();

        public Worm MyClone()
            => new Worm(Name, Organs, LimbsCount, EyesCount, HasTail, HasRegeneration);

        public override string? ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.Append($"Может регенерировать?: {HasRegeneration}\n");

            return sb.ToString();
        }
    }
}
