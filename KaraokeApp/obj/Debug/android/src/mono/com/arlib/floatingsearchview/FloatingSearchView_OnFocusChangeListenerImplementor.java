package mono.com.arlib.floatingsearchview;


public class FloatingSearchView_OnFocusChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.arlib.floatingsearchview.FloatingSearchView.OnFocusChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onFocus:()V:GetOnFocusHandler:FloatingSearchViews.FloatingSearchView/IOnFocusChangeListenerInvoker, FloatingSearchView\n" +
			"n_onFocusCleared:()V:GetOnFocusClearedHandler:FloatingSearchViews.FloatingSearchView/IOnFocusChangeListenerInvoker, FloatingSearchView\n" +
			"";
		mono.android.Runtime.register ("FloatingSearchViews.FloatingSearchView+IOnFocusChangeListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FloatingSearchView_OnFocusChangeListenerImplementor.class, __md_methods);
	}


	public FloatingSearchView_OnFocusChangeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FloatingSearchView_OnFocusChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("FloatingSearchViews.FloatingSearchView+IOnFocusChangeListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFocus ()
	{
		n_onFocus ();
	}

	private native void n_onFocus ();


	public void onFocusCleared ()
	{
		n_onFocusCleared ();
	}

	private native void n_onFocusCleared ();

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
