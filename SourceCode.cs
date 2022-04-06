        void Update()
        {
            /* Code here runs every frame when the mod is enabled */
            if (inRoom && GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().useGravity)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().AddForce(new Vector3(0f,5.2f,0f),ForceMode.Acceleration);
                // Low gravity YAAAAAAY

            }
        }

        /* This attribute tells Utilla to call this method when a modded room is joined */
        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
            /* Activate your mod here */
            /* This code will run regardless of if the mod is enabled*/

            inRoom = true;
        }

        /* This attribute tells Utilla to call this method when a modded room is left */
        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {
            /* Deactivate your mod here */
            /* This code will run regardless of if the mod is enabled*/

            inRoom = false;
        }
