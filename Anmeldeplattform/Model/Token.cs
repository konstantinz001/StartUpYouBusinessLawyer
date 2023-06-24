namespace Anmeldeplattform.Model
{
    public class StateContainerService
    {
        public bool _TokenLiveAnmeldung = true;
        public bool _TokenLiveCV = true;

        public event EventHandler StateChangedHandlerAnmeldung;

        public event EventHandler StateChangedHandlerCV;

        private void StateHasChangedAnmeldung()
        {
            StateChangedHandlerAnmeldung?.Invoke(this, EventArgs.Empty);
        }

        public bool GetTokeLiveAnmeldung()
        {
            return _TokenLiveAnmeldung;
        }

        public void SetTokeLiveAnmeldung(bool value) {
            _TokenLiveAnmeldung = value;
            StateHasChangedAnmeldung();
        }

        private void StateHasChangedCV()
        {
            StateChangedHandlerCV?.Invoke(this, EventArgs.Empty);
        }

        public bool GetTokeLiveCV()
        {
            return _TokenLiveCV;
        }

        public void SetTokeLiveCV(bool value)
        {
            _TokenLiveCV = value;
            StateHasChangedCV();
        }

    }
}
