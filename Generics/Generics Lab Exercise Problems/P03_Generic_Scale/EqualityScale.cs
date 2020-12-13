namespace GenericScale
{
    public class EqualityScale<T>
    {
        public T left;
        public T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            return this.left.Equals(this.right);
        }
    }
}
