# Integrating Human Data into Virtual Environments

> An experimental generative art work that integrates electroencephalography (EEG) activity with a virtual environment.
 
https://github.com/gscottqueen/emotiv-bci-hdrp-vr/assets/4613286/b60994c7-1414-48f2-8ca7-69ed2f323dfb

Combining the Emotiv Insight 2, five (5) channel EEG brainware, Meta Quest 2 virtual reality headset, and the Unity development platform we integrate streaming neurological data with real-time virtual interactions. Accessing six (6) performance metrics including; engagement, excitement, stress, relaxation, interest, and focus - alongside 9 axis motion sensors, we generate programmatic visuals that allow the user to interact and influence the immersive effects of the program. Users are able to either focus on one metric at a time or chain multiple experiences together, leading to the creation of a multitude of unique generative worlds.

This technology offers a personalized experience that allows users to engage with their cognitive states. By using internalized emotional focus they can shape visuals and interact with the program on a subconscious level. This bridge connects neuroscience, virtual reality, and interactive programming to open up applications in the research of mental wellness and technology through expressive sensibilities, aesthetics, and creative expression.

## Active Development

There are different builds and branches that are in active development, each has its own system and hardware requirements.

**Default System Requirements**

- PC with Graphics Enable GPU
  
  > I'm currently using
  > Version:  Direct3D 11.0 [level 11.1]
    Renderer: NVIDIA GeForce RTX 3070 Ti (ID=0x2482)
    Vendor:   NVIDIA
    VRAM:     8031 MB
    Driver:   31.0.15.2824
 
- Windows 10+ ( the emotiv launcher does not yet support Windows 11)
- Unity 2022+ ( current version is 2022.3.2f1), via the [Unity Hub](https://unity.com/unity-hub)
- [Meta Quest 2](https://www.meta.com/quest/products/quest-2/)
- [Meta Quest Developer Hub](https://developer.oculus.com/meta-quest-developer-hub/)
- [Meta Quest Developer Mode Access](https://www.bing.com/videos/search?q=how+to+set+up+developer+mode+oculus+2&qpvt=how+to+set+up+developer+mode+oculus+2&view=detail&mid=A4BE460E591842321D8BA4BE460E591842321D8B&&FORM=VRDGAR&ru=%2Fvideos%2Fsearch%3Fq%3Dhow%2Bto%2Bset%2Bup%2Bdeveloper%2Bmode%2Boculus%2B2%26qpvt%3Dhow%2Bto%2Bset%2Bup%2Bdeveloper%2Bmode%2Boculus%2B2%26FORM%3DVDRE)
- [Meta Link](https://www.meta.com/quest/setup/)

### 1. open-explore
This build package is for demonstration of interactions without the brainware dependency.

### 2. experimental-bci-integration-virtual

**Additional Dependencies**
- [Emotiv Launcher](https://www.emotiv.com/emotiv-launcher/)
- [Emotiv Developers License and Key](https://www.emotiv.com/developer/)

With this branch you can establish a virtual brainware device and use it to imulate generative conection points in the interactive experiences.

### 3. experimental-bci-integration

**Additional Dependencies**
- [Emotiv Insight 2 (5 channel) EEG](https://www.emotiv.com/insight/)

Same as above, but with a physical device connected via bluetooth.  This has some additinoal quaternion data points that are only avalible through the physical device.

Dependencies:

This project was initated by leveraging the [Emotiv-Unity-Plugin](https://github.com/Emotiv/unity-plugin) and is included with this project as a submodule.
