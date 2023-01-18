import { Box } from "@mui/system";
import { useEffect, useState } from "react";
import './SummonerData.css';


export default function SummonerData({ region, summonerName }) {
    const [isLoading, setIsLoading] = useState(true);
    const [summonerData, setSummonerData] = useState({});
    useEffect(() => {
        FetchProfile();
    }, []);

    async function FetchProfile() {
        const response = await fetch(`https://localhost:7178/Summoner?summonerName=${summonerName}&region=${region}`)
        const data = await response.json();
        setSummonerData(data.result);
        setIsLoading(false);
        console.log(data.result)
    }

    return (
        <Box>
            { 
                isLoading 
                    ||
                <div class="profile_content">
                    <div class="profile_icon_container">
                        <img class="profile_icon" src={`http://ddragon.leagueoflegends.com/cdn/13.1.1/img/profileicon/${summonerData.profileIconId}.png`}></img>
                        <span class="summoner_level">{summonerData.summonerLevel}</span>
                    </div>
                    <div class="profile_info">
                        <div class="profile_info_summoner_name">{summonerName} <span class="profile_info_region">{region}</span></div>
                    </div>
                </div>
            }
        </Box>
    )
}