# Integrating Human Data into Virtual Environments

> An experimental generative art work that integrates electroencephalography (EEG) activity with a virtual environment.

[Supplemental Research & Writing](https://docs.google.com/document/d/1fecL9E1dA5AUxQGLOU4fsZUmMXT6Wm6GzOxjJ7qpnlI/edit?usp=drivesdk)

https://github.com/gscottqueen/emotiv-bci-hdrp-vr/assets/4613286/b60994c7-1414-48f2-8ca7-69ed2f323dfb

Combining the Emotiv Insight 2, five (5) channel EEG brainware, Meta Quest 2 virtual reality headset, and the Unity development platform we integrate streaming neurological data with real-time virtual interactions. Accessing six (6) performance metrics including; engagement, excitement, stress, relaxation, interest, and focus - alongside 9 axis motion sensors, we generate programmatic visuals that allow the user to interact and influence the immersive effects of the program. Users are able to either focus on one metric at a time or chain multiple experiences together, leading to the creation of a multitude of unique generative worlds.

This technology offers a personalized experience that allows users to engage with their cognitive states. By using internalized emotional focus they can shape visuals and interact with the program on a subconscious level. This bridge connects neuroscience, virtual reality, and interactive programming to open up applications in the research of mental wellness and technology through expressive sensibilities, aesthetics, and creative expression.

## Screen Captures

<img src="https://github.com/gscottqueen/emotiv-bci-hdrp-vr/assets/4613286/8f290ec8-5e5a-4f5d-aa3a-dba1551fc07e" width=50% height=50%>

</br>

- The High Definition Render Pipeline (HDRP) is a high-fidelity Scriptable Render Pipeline built by Unity to target modern (Compute Shader compatible) platforms. HDRP utilizes physically based Lighting techniques, linear lighting, HDR lighting, and a configurable hybrid Tile/Cluster deferred/Forward lighting architecture. ([source](https://www.bing.com/search?pglt=41&q=high+definition+rendering+pipeline&cvid=90e88c5abd584a6e9d01aba3541f2dc8&aqs=edge.0.0j69i57j0l7.5238j0j1&FORM=ANAB01&PC=U531))

</br>

<img src="https://github.com/gscottqueen/emotiv-bci-hdrp-vr/assets/4613286/5edaa554-ad9e-4265-84b5-49a05372d43c" width=50% height=50%>

</br>

- The graphic menu is integrated to search for avalible devices via bluetooth and allow a user to select which device they would like to integrate with the session.

</br>

<img src="https://github.com/gscottqueen/emotiv-bci-hdrp-vr/assets/4613286/e17efe84-71ec-4475-acd3-8e47be5b69c7" width=50% height=50%>

</br>

- When the channels for emotional response are of a connectivity value greater than 80%, interactive elements intantiate into the scene. Here each of these boxes represents a different emotional data point.

</br>

<img src="https://github.com/gscottqueen/emotiv-bci-hdrp-vr/assets/4613286/7d352ad1-f6cf-4711-9408-7f947754fc08" width=50% height=50%>

</br>

- These data points are then passed through to generative visual effects, like this particle ray system.
 
</br>
 
<img src="https://github.com/gscottqueen/emotiv-bci-hdrp-vr/assets/4613286/e86adae5-7a0c-4d04-b89a-a5bea594c0d6" width=50% height=50%>

</br>

- In some cases we work to push the graphical limits. In this scene we are baking 500000+ animated hair material frames. Eventualy we will push this work to the [DOTS programing design pattern](https://unity.com/dots) to see these limits go even further.

</br>




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

### 1. Open Explore
[This build package is for demonstration of interactions without the brainware dependency.](https://drive.google.com/file/d/1Qlgar3oFswinqbXLeUL5ud7afwuF94OQ/view?usp=sharing)

### 2. experimental-bci-integration-virtual

We use this branch to work virtualized hardware from the Emotiv Launcher.

**Additional Dependencies**
- [Emotiv Launcher](https://www.emotiv.com/emotiv-launcher/)
- [Emotiv Developers License and Key](https://www.emotiv.com/developer/)

With this branch you can establish a virtual brainware device and use it to imulate generative conection points in the interactive experiences.

### 3. experimental-bci-integration

We use this branch to work with physical brainware.

**Additional Dependencies**
- [Emotiv Insight 2 (5 channel) EEG](https://www.emotiv.com/insight/)

Same as above, but with a physical device connected via bluetooth.  This has some additinoal quaternion data points that are only avalible through the physical device.

#### Dependencies:

This project was initated by leveraging the [Emotiv-Unity-Plugin](https://github.com/Emotiv/unity-plugin) and is included with this project as a submodule.
