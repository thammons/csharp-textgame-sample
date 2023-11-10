public class Story
{

    public Scene[] GetScenes()
    {

        var scenes = new Scene[] {
    new Scene
    {
        Id = 0,
        Description = "You are in a forest. There is a path to the north. There is a Shovel to the east. There is a howel in the distance. A chill runs down your spine and you glance over your shoulder.",
        Options = new SceneOption[]{
            new SceneOption{Description = "Go north",NextSceneId = 1},
            new SceneOption{Description = "Grab the shovel",NextSceneId = 6},
            new SceneOption{Description = "Investigate the howl...",NextSceneId = 3},
            new SceneOption{Description = "RUN AWAY!",NextSceneId = 4},
        }
    },
    new Scene
    {
        Id = 1,
        Description = "You are in a clearing. The distant bushes rustle to the west. You hear the trickle of a small stream to the north. You again, hear a troublesome howl.",
        Options = new SceneOption[]{
            new SceneOption{Description = "Go south",NextSceneId = 0},
            new SceneOption{Description = "Move toward the stream",NextSceneId = 2},
            new SceneOption{Description = "Investigate the howl...",NextSceneId = 3},
        }
    },
    new Scene
    {
        Id = 2,
        Description = "You are at a stream. The water is clear and cool. You see a fish swimming in the stream. You hear the howl again, this time it sounds closer.",
        Options = new SceneOption[]{
            new SceneOption{Description = "Go back to the clearing",NextSceneId = 1},
            new SceneOption{Description = "Grab the fish",NextSceneId = 5},
            new SceneOption{Description = "Investigate the howl...",NextSceneId = 3},
        }
    },
    new Scene
    {
        Id = 3,
        Description = "You slowly move toward the howl. You see a wolf. It is injured. It looks at you with pleading eyes. You hear the howl again, this time it sounds closer.",
        Options = new SceneOption[]{
            new SceneOption{Description = "Go south",NextSceneId = 0},
            new SceneOption{Description = "Move toward the stream",NextSceneId = 2},
            new SceneOption{Description = "Investigate the howl...",NextSceneId = 3},
            new SceneOption{Description = "RUN AWAY!",NextSceneId = 4},
        }
    },
    new Scene
    {
        Id = 4,
        Description = "You ran away. As fast and as far as your legs could carry you... as far as your arms would drag you. My voice is now ownly a distant whisper in the wind... see you again soon...",
        Options = new SceneOption[]{
            new SceneOption{Description = "Exit Game",NextSceneId = -1},
        }
    },
    new Scene
    {
        Id = 5,
        Description = "You grab the fish. It is slippery and wiggles in your hands. You hear the howl again, this time it sounds closer. You stuff the fish in your bag and...",
        Options = new SceneOption[]{
            new SceneOption{Description = "Go back to the clearing",NextSceneId = 1},
            new SceneOption{Description = "Investigate the howl...",NextSceneId = 3},
            new SceneOption{Description = "I see you enjoy collecting things.. Would you like a shovel?" ,NextSceneId = 6},
        }
    },
    new Scene
    {
        Id = 6,
        Description = "You grab the shovel. It is heavy and cold. You hear the howl again, this time it sounds closer. You stuff the shovel in your bag and...",
        Options = new SceneOption[]{
            new SceneOption{Description = "Go back to the clearing",NextSceneId = 1},
            new SceneOption{Description = "Investigate the howl...",NextSceneId = 3},
            new SceneOption{Description = "I see you enjoy collecting things.. Would you like a fish?" ,NextSceneId = 5},
        }
    },
};
        return scenes;
    }
}