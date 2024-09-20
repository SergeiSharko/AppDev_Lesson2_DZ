namespace Lesson2_DZ
{
    internal class Bits
    {
        private long value;

        // Неявное приведение из long
        public static implicit operator Bits(long v)
        {
            return new Bits { value = v };
        }

        // Неявное приведение из int
        public static implicit operator Bits(int v)
        {
            return new Bits { value = v };
        }

        // Неявное приведение из byte
        public static implicit operator Bits(byte v)
        {
            return new Bits { value = v };
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
