using System.Text;

namespace OtusHW11.Models.Abstract
{
    /// <summary>
    ///     Животное.
    /// </summary>
    public abstract class Animal : Organism
    {
        public Animal(string name,
            List<Organ> organs,
            int limbsCount,
            int eyesCount,
            bool hasTail) : base(name, organs)
        {
            LimbsCount = limbsCount;
            EyesCount = eyesCount;
            HasTail = hasTail;
        }

        /// <summary>
        ///     Количество конечностей.
        /// </summary>
        public int LimbsCount { get; }

        /// <summary>
        ///     Количество глаз.
        /// </summary>
        public int EyesCount { get; }

        /// <summary>
        ///     Признак наличия хвоста.
        /// </summary>
        public bool HasTail { get; }

        public override string? ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.Append($"Количество конечностей: {LimbsCount}\n" +
            $"Количество глаз: {EyesCount}\n" +
            $"Есть хвост?: {HasTail}\n");

            return sb.ToString();
        }
    }
}
