Medium: Speed up Play mode with Editor settings. Reduce waiting time when testing your game by changing how Unity reloads upon entering Play mode. From the top menu, go to Edit > Project Settings > Editor. 
Under Enter Play Mode Settings, set the When entering Play mode property to Do not reload domain or Scene.Normally, Unity resets and reloads the entire project every time you select the Play button— which takes a few seconds. 
By disabling domain and scene reloads, Unity skips that reset, so your game enters Play mode almost instantly.
It’s a huge time-saver during early development.
1. Experiment with different Game view resolutions:
In the Game view, use the aspect ratio dropdown to select a few different screen resolutions.
Notice that the score text gets smaller and changes position at higher resolutions.
2. Select the Panel Settings asset:
In the Project window, locate the Panel Settings asset that was automatically created when you added the UI Document to the scene. It’s usually inside a folder called UI Toolkit or next to your UILayout asset.
Tip: You can search the entire Assets folder using the search bar.
3. Set it to scale with the screen size:
With the Panel Settings asset selected, in the Inspector window, set the Scale Mode property to Scale With Screen Size.
4. Adjust the reference resolution if needed:
If the UI elements became smaller or larger than you’d like, under the Scale Mode Parameters section, increase or decrease the Reference Resolution Width and Height properties.
After changing this setting, test different Game view aspect ratios from the dropdown in the Game view or by dragging the top edge of the Game view up and down. The score label should now stay anchored and readable regardless of window size.
