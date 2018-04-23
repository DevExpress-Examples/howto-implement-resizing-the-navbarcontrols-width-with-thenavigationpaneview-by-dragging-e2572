# How to implement resizing the NavBarControl's width with the NavigationPaneView by dragging


<p>This example demonstrates how to implement resizing the NavBarControl's width with the NavigationPaneView by dragging.</p>
<p>Our NavBarControl with NavigationPaneView does not implement resizing its width by dragging. To implement this functionality, we use the Thumb to control the NavBarControl's MaxWidth. We subscribe to the Thumb's DragDelta event. When DragDelta is raised, we calculate the required NavBarControl's Width using DragDeltaEventArgs's HorizontalChange property and check the result. If it's less than the NavBarControl's MinWidth, we set NavigationPaneView's IsExpanded property to false and call the Thumb's CancelDrag method. If its greater than NavBarControl's MinWidth, we set NavigationPaneView's IsExpanded property to true and set NavBarControl's MaxWidth to the required value.</p>

<br/>


