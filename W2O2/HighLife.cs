namespace ConwayGameOfLife
{
    public class HighLife : ConwayGameOfLife
    {
        protected override bool CellShouldLive(bool livingCell, int neighbourCount)
        {

            // with 3 neighbour cell will live
            if (neighbourCount == 2)
                return livingCell;

            // live cell with 3 or 6 neighbours stays alive
            if (neighbourCount == 3 || neighbourCount == 6)
                return true;

            // dead cell
            return false;
        }
    }
}