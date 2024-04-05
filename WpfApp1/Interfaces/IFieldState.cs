namespace WpfApp1.Interfaces
{
    public interface IFieldState
    {
        void Draw(string player, int fieldnumber);
        void PlayerWin();
        void ShowField();
    }
}