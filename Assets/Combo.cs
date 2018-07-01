// GENERATED AUTOMATICALLY FROM 'Assets/Combo.inputactions'

[System.Serializable]
public class Combo : UnityEngine.Experimental.Input.InputActionWrapper
{
    private bool m_Initialized;
    private void Initialize()
    {
        // wom wom
        m_womwom = asset.GetActionMap("wom wom");
        m_womwom_action = m_womwom.GetAction("action");
        m_Initialized = true;
    }
    // wom wom
    private UnityEngine.Experimental.Input.InputActionMap m_womwom;
    private UnityEngine.Experimental.Input.InputAction m_womwom_action;
    public struct WomwomActions
    {
        private Combo m_Wrapper;
        public WomwomActions(Combo wrapper) { m_Wrapper = wrapper; }
        public UnityEngine.Experimental.Input.InputAction @action { get { return m_Wrapper.m_womwom_action; } }
        public UnityEngine.Experimental.Input.InputActionMap Get() { return m_Wrapper.m_womwom; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public UnityEngine.Experimental.Input.InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator UnityEngine.Experimental.Input.InputActionMap(WomwomActions set) { return set.Get(); }
    }
    public WomwomActions @womwom
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new WomwomActions(this);
        }
    }
}
