namespace raygui_cs
{
    /// <summary>
    /// Act like a string pointer to help reduce heap allocation.
    /// </summary>
    public struct ReadonlyString
    {
        public string Ref;
        public int Start;
        public int Length;
        public char this [ int index ]
        {
            get
            {
                return Ref [ index + Start ];
            }
        }
    }
}
