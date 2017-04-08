namespace ChessInheritence.Chess.Utilities
{
    public static class ArrayExtension
    {
        public static void Fill<T>(this T[,] array, T content1, T content2, int size)
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    array[i, j] = (i + j) % 2 == 0 ? content1 : content2;
                }
            }
        }
    }
}
