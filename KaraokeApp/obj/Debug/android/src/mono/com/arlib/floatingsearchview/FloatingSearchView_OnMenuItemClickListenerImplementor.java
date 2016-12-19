package mono.com.arlib.floatingsearchview;


public class FloatingSearchView_OnMenuItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.arlib.floatingsearchview.FloatingSearchView.OnMenuItemClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMenuItemSelected:(Landroid/view/MenuItem;)V:GetOnMenuItemSelected_Landroid_view_MenuItem_Handler:FloatingSearchViews.FloatingSearchView/IOnMenuItemClickListenerInvoker, FloatingSearchView\n" +
			"";
		mono.android.Runtime.register ("FloatingSearchViews.FloatingSearchView+IOnMenuItemClickListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FloatingSearchView_OnMenuItemClickListenerImplementor.class, __md_methods);
	}


	public FloatingSearchView_OnMenuItemClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FloatingSearchView_OnMenuItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("FloatingSearchViews.FloatingSearchView+IOnMenuItemClickListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMenuItemSelected (android.view.MenuItem p0)
	{
		n_onMenuItemSelected (p0);
	}

	private native void n_onMenuItemSelected (android.view.MenuItem p0);

	private java.util.ArrayList refList;
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
