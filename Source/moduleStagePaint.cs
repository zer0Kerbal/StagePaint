/* GPLv2
 * zer0Kerbal
 * 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.UI.Screens; 
using KSP.Localization;
using System.IO;
using UnityEngine.Networking;

namespace StagePaint
{
    public class moduleStagePaint : PartModule
    {

        [KSPField(isPersistant = true, guiActive = false)]
        private bool _isEnabled = true;

        [KSPField(isPersistant = true, guiActive = false)]
        private bool _blink = false;

        [KSPField(isPersistant = true, guiActive = false)]
        private float _blinkInterval = 1.0f;

        [KSPField(isPersistant = true, guiActive = false)]
        public bool _blinkBorder = false;
        
        [KSPField(isPersistant = true, guiActive = false)]
        public Color32 _setIconColor = Color.white;

        [KSPField(isPersistant = true, guiActive = false)]
        public Color _SetBackgroundColor; // (Color color)
        
        [KSPField(isPersistant = true, guiActive = false)]
        public Color _SetBorderColor; // (Color color)
        
        [KSPField(isPersistant = true, guiActive = false)]
        public Texture2D _SetIcon;  // (Texture2D texture, int x, int y)
        public string _customIconFilePath = String.Empty;
        public int _iconX = 64;
        public int _iconY = 64;
        // void SetIcon (string customIconFilePath, int x, int y)

        [KSPField(isPersistant = true, guiActive = false)]
        public StageIcon _backgroundImage;
        
        [KSPField(isPersistant = true, guiActive = false)]
        public bool _savedBoolean;

        public bool IsEnabled { get => _isEnabled; set => _isEnabled = value; }
        public bool Blink { get => _blink; set => _blink = value; }
        public float BlinkInterval { get => _blinkInterval; set => _blinkInterval = value; }


        public override void OnActive()
        {
            base.OnActive();    
        }

        public override void OnAwake()
        {
            base.OnAwake(); 
        }

        public override void OnStart(PartModule.StartState state)
        {
            // Log.Info(msg:"OnStart");
            if (IsEnabled)
            {
                moduleStagePaint moduleStagePaint = this;
                moduleStagePaint.part.stackIcon.SetIconColor(XKCDColors.Apricot);
                moduleStagePaint.part.stackIcon.SetBackgroundColor(XKCDColors.AquaBlue);
                moduleStagePaint.part.stackIcon.SetBorderColor(XKCDColors.Gold);
                this.part.stackIcon.BlinkBorder(0.25f);
            }
        }

        public override void OnInitialize()
        {
            base.OnInitialize();
        }

        public override void OnIconCreate()
        {
            base.OnIconCreate();
        }

        public override void SetStaging(bool newValue)
        {
            base.SetStaging(newValue);
        }

        public override void ApplyUpgradeNode(List<string> appliedUps, ConfigNode node, bool doLoad)
        {
            base.ApplyUpgradeNode(appliedUps, node, doLoad);
        }

        public override void OnUpdate()
        {
            base.OnUpdate();    
        }

        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();   
        }

        public override void OnSave(ConfigNode node)
        {
            base.OnSave(node);
        }

        public override void OnLoad(ConfigNode node)
        {
            base.OnLoad(node);  
        }
    }
}

/*part.stackIcon.SetIconColor(XKCDColors.FireEngineRed);


StageIcon.blinkBorder = false

blinkInterval = 1.0f

iconType = DefaultIcons.CUSTOM //MYSTERY_PART

StageIcon.textStar

void SetIcon (DefaultIcons icon)


void SetIconColor (Color color)*/

