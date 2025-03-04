using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RemoteTimer.Models.DataLayer;

namespace RemoteTimer.GridHandlers
{
    public abstract class GridHandler
    {
        protected DataGridView Grid { get; private set; }
        protected RemoteTimerDatabaseContext Context { get; private set; }

        public GridHandler(DataGridView grid)
        {
            Grid = grid;
            Context = DatabaseLoader.Instance.Context;
        }

        public void LoadGrid()
        {

        }
    }
}