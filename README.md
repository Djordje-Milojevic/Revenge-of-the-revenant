Medium: Speed up Play mode with Editor settings. Reduce waiting time when testing your game by changing how Unity reloads upon entering Play mode. From the top menu, go to Edit > Project Settings > Editor. 
Under Enter Play Mode Settings, set the When entering Play mode property to Do not reload domain or Scene.Normally, Unity resets and reloads the entire project every time you select the Play button— which takes a few seconds. 
By disabling domain and scene reloads, Unity skips that reset, so your game enters Play mode almost instantly.
It’s a huge time-saver during early development.
