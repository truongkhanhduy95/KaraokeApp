package mono.com.arlib.floatingsearchview;


public class FloatingSearchView_OnLeftMenuClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.arlib.floatingsearchview.FloatingSearchView.OnLeftMenuClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMenuClosed:()V:GetOnMenuClosedHandler:FloatingSearchViews.FloatingSearchView/IOnLeftMenuClickListenerInvoker, FloatingSearchView\n" +
			"n_onMenuOpened:()V:GetOnMenuOpenedHandler:FloatingSearchViews.FloatingSearchView/IOnLeftMenuClickListenerInvoker, FloatingSearchView\n" +
			"";
		mono.android.Runtime.register ("FloatingSearchViews.FloatingSearchView+IOnLeftMenuClickListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FloatingSearchView_OnLeftMenuClickListenerImplementor.class, __md_methods);
	}


	public FloatingSearchView_OnLeftMenuClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FloatingSearchView_OnLeftMenuClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("FloatingSearchViews.FloatingSearchView+IOnLeftMenuClickListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMenuClosed ()
	{
		n_onMenuClosed ();
	}

	private native void n_onMenuClosed ();


	public void onMenuOpened ()
	{
		n_onMenuOpened ();
	}

	private native void n_onMenuOpened ();

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
