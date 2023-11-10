public class Scene
{
    public int Id { get; set; }
    public int LastSceneId { get; set; }
    public string Description { get; set; }
    public SceneOption[] Options { get; set; }
}