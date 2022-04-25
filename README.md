# rl-karting
Karting game with RL agents based on the Unity karting microgame. 

## Setup
The setup which we've been working on and recommend to ensure that everything is compatible is:
- Unity 2020.3.29f1 with MLAgent v1.0.8 and ProGrids packages.
- Python 3.7 with
  - mlagent==0.20.0
  - tensorflow==2.7.0
  - numpy==1.18.5
For ease of package version control, we recommend using either Anaconda or virtualenv for Python and Unity Hub for Unity.

## Guide
- *Assets/Karting/Scenes/GameplayGyms/MainGame/* contains the gameplay scenes with our sample setup, with IntroMenu.unity being the starting scene
- *Assets/Karting/Scenes/MLTraining/* contains the scenes used in training. Alongside the default ones, TrainingScene.unity is one of the variations of scenes we used to train our bots.
- *Assets/Karting/Prefabs/AI/OurBots/* has sample neural network models trained by us in this environment.
- *Assets/Karting/Prefabs/AI/new_kart_mg_trainer_config.yaml* is a sample training config.

To train new bots, all you have to do is launch the following command within your python environment:
```
mlagents-learn <agent_config_path> --run-id=<run_id>
```
This will launch MLAgents, which after initialization will tell you to click ▶ in Unity on the training scene. After this, MLAgents will handle everything!
It will also automatically create *results* directory for tensorboard, which you can check out with:
```
tensorboard --logdir results
```
