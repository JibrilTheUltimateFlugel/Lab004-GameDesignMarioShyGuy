# Lab004-GameDesignMarioShyGuy
Lab 004 for Game Design and Development

Implemented Features:
- Enemy Pooling System/ObjectPooler with 2 enemy types (Shy guy and Goomba) and Spawn 2 enemies at start, killing enemies awards +1 score but will spawn 1 new random enemy from the pool
- Interactive Breakable Bricks that spawn Coins upon hit, collecting coin +1 score but spawn 1 new random enemy from the pool
- Enemy Rejoice animation by flipping left and right whenever they successfully kill Mario if Mario collides into an enemy from the side, there is also an Animation for Mario death & sound effects
- AudioMixer with different groups such as Background Sound, Item SFX, Player SFX, with different effects as well (Pitch Shifter, Lowpass, Reverb, etc)
- Two different powerups collected from ? Box which is the Red Mushroom that increases Mario jump height (upSpeed), and Green Mushroom that increases Mario speed by doubling it, these effects last temporary, simple inventory system that allows player to cast using the Z and X keys
- Scriptable Object to store Game Constants such as Enemy Patrol Time, Offset, and also rotator rotation speed for the spinning platforms
