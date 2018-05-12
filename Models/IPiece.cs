using System.Threading.Tasks;

namespace ChessApi.Models
{
    public interface IPiece
    {
        Task<bool> CanAttack(Position target);
        Task<bool> CanMove(Position target);
    }
}