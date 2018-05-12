using System;
using System.Threading.Tasks;

namespace ChessApi.Models
{
    public class QueenPiece : IPiece
    {
        private Position currentPosition { get; set; }

        public QueenPiece(Position position)
        {
            currentPosition = position;
        }
        public async Task<bool> CanAttack(Position position)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> CanMove(Position target)
        {
            throw new NotImplementedException();
        }
    }
}