namespace RouteTeamStudio.Utility
{
    public class Fsm
    {
        public enum Step
        {
            Enter,
            Update,
            Exit
        }

        public delegate void State(Fsm fsm, Step step, State state);

        State _currentState;

        public void OnStart(State startState)
        {
            TransitionTo(startState);
        }

        public void OnUpdate()
        {
            _currentState.Invoke(this, Step.Update, null);
        }

        public void TransitionTo(State state)
        {
            if (state == _currentState) return;

            _currentState?.Invoke(this, Step.Exit, state);
            var oldState = _currentState;
            _currentState = state;
            _currentState.Invoke(this, Step.Enter, oldState);
        }
    }
}
