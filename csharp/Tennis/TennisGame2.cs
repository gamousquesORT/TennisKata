namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int playerOnePoint;
        private int playerTwoPoint;

        private string playerOneResult = "";
        private string playerTwoResult = "";
        private string playerOneName;
        private string playerTwoName;

        public TennisGame2(string playerOneName, string playerTwoName)
        {
            this.playerOneName = playerOneName;
            playerOnePoint = 0;
            this.playerTwoName = playerTwoName;
        }

        public string GetScore()
        {
            var score = "";
            if (playerOnePoint == playerTwoPoint && playerOnePoint < 3)
            {
                score = GetIdenticalScore(score);
            }
            if (playerOnePoint == playerTwoPoint && playerOnePoint > 2)
                score = "Deuce";

            if (playerOnePoint > 0 && playerTwoPoint == 0)
            {
                score = GetPlayerOneWinScore();
            }
            if (playerTwoPoint > 0 && playerOnePoint == 0)
            {
                score = GetPlayerTwoWinScore();
            }

            if (playerOnePoint > playerTwoPoint && playerOnePoint < 4)
            {
                score = GetPlayerOneAndTwoAtThirtyScore();
            }
            if (playerTwoPoint > playerOnePoint && playerTwoPoint < 4)
            {
                score = GetPlayerTwoAndOneAtThirtyScore();
            }

            if (playerOnePoint > playerTwoPoint && playerTwoPoint >= 3)
            {
                score = "Advantage player1";
            }

            if (playerTwoPoint > playerOnePoint && playerOnePoint >= 3)
            {
                score = "Advantage player2";
            }

            if (playerOnePoint >= 4 && playerTwoPoint >= 0 && (playerOnePoint - playerTwoPoint) >= 2)
            {
                score = "Win for player1";
            }
            if (playerTwoPoint >= 4 && playerOnePoint >= 0 && (playerTwoPoint - playerOnePoint) >= 2)
            {
                score = "Win for player2";
            }
            return score;
        }

        private string GetPlayerTwoAndOneAtThirtyScore()
        {
            string score;
            if (playerTwoPoint == 2)
                playerTwoResult = "Thirty";
            if (playerTwoPoint == 3)
                playerTwoResult = "Forty";
            if (playerOnePoint == 1)
                playerOneResult = "Fifteen";
            if (playerOnePoint == 2)
                playerOneResult = "Thirty";
            score = playerOneResult + "-" + playerTwoResult;
            return score;
        }

        private string GetPlayerOneAndTwoAtThirtyScore()
        {
            string score;
            if (playerOnePoint == 2)
                playerOneResult = "Thirty";
            if (playerOnePoint == 3)
                playerOneResult = "Forty";
            if (playerTwoPoint == 1)
                playerTwoResult = "Fifteen";
            if (playerTwoPoint == 2)
                playerTwoResult = "Thirty";
            score = playerOneResult + "-" + playerTwoResult;
            return score;
        }

        private string GetPlayerTwoWinScore()
        {
            string score;
            if (playerTwoPoint == 1)
                playerTwoResult = "Fifteen";
            if (playerTwoPoint == 2)
                playerTwoResult = "Thirty";
            if (playerTwoPoint == 3)
                playerTwoResult = "Forty";

            playerOneResult = "Love";
            score = playerOneResult + "-" + playerTwoResult;
            return score;
        }

        private string GetPlayerOneWinScore()
        {
            string score;
            if (playerOnePoint == 1)
                playerOneResult = "Fifteen";
            if (playerOnePoint == 2)
                playerOneResult = "Thirty";
            if (playerOnePoint == 3)
                playerOneResult = "Forty";

            playerTwoResult = "Love";
            score = playerOneResult + "-" + playerTwoResult;
            return score;
        }

        private string GetIdenticalScore(string score)
        {
            if (playerOnePoint == 0)
                score = "Love";
            if (playerOnePoint == 1)
                score = "Fifteen";
            if (playerOnePoint == 2)
                score = "Thirty";
            score += "-All";
            return score;
        }

        public void SetP1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                P2Score();
            }
        }

        private void P1Score()
        {
            playerOnePoint++;
        }

        private void P2Score()
        {
            playerTwoPoint++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }

    }
}

