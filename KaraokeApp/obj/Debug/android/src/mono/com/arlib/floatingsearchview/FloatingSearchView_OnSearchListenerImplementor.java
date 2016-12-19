package mono.com.arlib.floatingsearchview;


public class FloatingSearchView_OnSearchListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.arlib.floatingsearchview.FloatingSearchView.OnSearchListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSearchAction:()V:GetOnSearchActionHandler:FloatingSearchViews.FloatingSearchView/IOnSearchListenerInvoker, FloatingSearchView\n" +
			"n_onSuggestionClicked:(Lcom/arlib/floatingsearchview/suggestions/model/SearchSuggestion;)V:GetOnSuggestionClicked_Lcom_arlib_floatingsearchview_suggestions_model_SearchSuggestion_Handler:FloatingSearchViews.FloatingSearchView/IOnSearchListenerInvoker, FloatingSearchView\n" +
			"";
		mono.android.Runtime.register ("FloatingSearchViews.FloatingSearchView+IOnSearchListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FloatingSearchView_OnSearchListenerImplementor.class, __md_methods);
	}


	public FloatingSearchView_OnSearchListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FloatingSearchView_OnSearchListenerImplementor.class)
			mono.android.TypeManager.Activate ("FloatingSearchViews.FloatingSearchView+IOnSearchListenerImplementor, FloatingSearchView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSearchAction ()
	{
		n_onSearchAction ();
	}

	private native void n_onSearchAction ();


	public void onSuggestionClicked (com.arlib.floatingsearchview.suggestions.model.SearchSuggestion p0)
	{
		n_onSuggestionClicked (p0);
	}

	private native void n_onSuggestionClicked (com.arlib.floatingsearchview.suggestions.model.SearchSuggestion p0);

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
