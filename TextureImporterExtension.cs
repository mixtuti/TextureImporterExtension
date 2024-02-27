using UnityEditor;
using UnityEngine;

public class TextureImporterExtension : AssetPostprocessor
{
    void OnPreprocessTexture()
    {
        if (assetImporter is TextureImporter textureImporter)
        {
            textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.spriteImportMode = SpriteImportMode.Single;
        }
    }
}
