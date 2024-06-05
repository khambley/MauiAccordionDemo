﻿using MauiAccordionExpanderDemo.ViewModels;
using epj.Expander.Maui;

namespace MauiAccordionExpanderDemo;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new AccordionViewModel();

	}

    void Expander_OnHeaderTapped(System.Object sender, ExpandedEventArgs e)
    {
        if (sender is not Expander expander)
        {
            return;
        }

        var children = expander.GetVisualTreeDescendants();
        var downArrowLabel = (Label)children[5];
        var upArrowLabel = (Label)children[6];
        if (downArrowLabel.IsVisible)
        {
            downArrowLabel.IsVisible = false;
            upArrowLabel.IsVisible = true;
        }
        else
        {
            downArrowLabel.IsVisible = true;
            upArrowLabel.IsVisible = false;
        }
        
        
        // This is optional. This is to prevent other expanders to be opened when the active one is opened. KLH
        foreach (var child in AccordionLayout.Children)
        {
            if (child is not Expander other)
            {
                continue;
                
            }

            if (other != expander)
            {
                other.IsExpanded = false;
            }
        }
        
        
        
    }
}


