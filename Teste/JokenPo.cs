namespace Teste
{
    public class JokenPo
    {
        public string Play(JokenPoEnum player1, JokenPoEnum player2)
        {
            if (player1 == player2)
                return "Draw";

            if (player1 == JokenPoEnum.Pencil || player2 == JokenPoEnum.Pencil)
                return JokenPoEnum.Pencil.ToString();

            switch (player1, player2)
            {
                case (JokenPoEnum.Paper, JokenPoEnum.Scissor):
                    return JokenPoEnum.Scissor.ToString();
                case (JokenPoEnum.Paper, JokenPoEnum.Rock):
                    return JokenPoEnum.Paper.ToString();
                case (JokenPoEnum.Scissor, JokenPoEnum.Paper):
                    return JokenPoEnum.Scissor.ToString();
                case (JokenPoEnum.Scissor, JokenPoEnum.Rock):
                    return JokenPoEnum.Rock.ToString();
                case (JokenPoEnum.Rock, JokenPoEnum.Paper):
                    return JokenPoEnum.Paper.ToString();
                case (JokenPoEnum.Rock, JokenPoEnum.Scissor):
                    return JokenPoEnum.Rock.ToString();
                default:
                    throw new System.Exception("Jogada inválida");
            }
        }
    }

    public enum JokenPoEnum
    {
        Paper,
        Scissor,
        Rock,
        Pencil
    }
}
