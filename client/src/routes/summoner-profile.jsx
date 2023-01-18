import { Box } from "@mui/system";
import { useEffect } from "react";
import { useParams } from "react-router-dom";
import SummonerData from "../components/profile/SummonerData";

export default function SummonerProfile() {
    let { region, summonerName } = useParams()

    return (
        <div className="summoner-profile-container">
            <SummonerData 
                region={region} 
                summonerName={summonerName} 
            />

            <Box>

            </Box>
        </div>
    )
}